# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class MethodRequestResponse(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    def __init__(self, request_payload: object=None, response_id: str=None):  # noqa: E501
        """MethodRequestResponse - a model defined in Swagger

        :param request_payload: The request_payload of this MethodRequestResponse.  # noqa: E501
        :type request_payload: object
        :param response_id: The response_id of this MethodRequestResponse.  # noqa: E501
        :type response_id: str
        """
        self.swagger_types = {
            'request_payload': object,
            'response_id': str
        }

        self.attribute_map = {
            'request_payload': 'requestPayload',
            'response_id': 'responseId'
        }

        self._request_payload = request_payload
        self._response_id = response_id

    @classmethod
    def from_dict(cls, dikt) -> 'MethodRequestResponse':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The methodRequestResponse of this MethodRequestResponse.  # noqa: E501
        :rtype: MethodRequestResponse
        """
        return util.deserialize_model(dikt, cls)

    @property
    def request_payload(self) -> object:
        """Gets the request_payload of this MethodRequestResponse.

        payload for the request that arrived from the service  # noqa: E501

        :return: The request_payload of this MethodRequestResponse.
        :rtype: object
        """
        return self._request_payload

    @request_payload.setter
    def request_payload(self, request_payload: object):
        """Sets the request_payload of this MethodRequestResponse.

        payload for the request that arrived from the service  # noqa: E501

        :param request_payload: The request_payload of this MethodRequestResponse.
        :type request_payload: object
        """

        self._request_payload = request_payload

    @property
    def response_id(self) -> str:
        """Gets the response_id of this MethodRequestResponse.

        response ID to be used when responding to this method call  # noqa: E501

        :return: The response_id of this MethodRequestResponse.
        :rtype: str
        """
        return self._response_id

    @response_id.setter
    def response_id(self, response_id: str):
        """Sets the response_id of this MethodRequestResponse.

        response ID to be used when responding to this method call  # noqa: E501

        :param response_id: The response_id of this MethodRequestResponse.
        :type response_id: str
        """

        self._response_id = response_id