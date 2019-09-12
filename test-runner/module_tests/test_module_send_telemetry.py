# Copyright (c) Microsoft. All rights reserved.
# Licensed under the MIT license. See LICENSE file in the project root for
# full license information.

import pytest
import connections
import test_utilities
from runtime_config import get_current_config
from adapters import print_message as log_message


@pytest.mark.testgroup_edgehub_module_client
@pytest.mark.testgroup_iothub_module_client
@pytest.mark.callsSendEvent
@pytest.mark.timeout(
    timeout=180
)  # extra timeout in case eventhub needs to retry due to resource error
def test_module_send_event_to_iothub(test_object_stringified):

    module_client = connections.connect_test_module_client()
    eventhub_client = connections.connect_eventhub_client()

    module_client.send_event(test_object_stringified)

    received_message = eventhub_client.wait_for_next_event(
        get_current_config().test_module.device_id,
        test_utilities.default_eventhub_timeout,
        expected=test_object_stringified,
    )
    if not received_message:
        log_message("Message not received")
        assert False

    module_client.disconnect()
    eventhub_client.disconnect()
