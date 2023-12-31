﻿using System.Net;
using CSI.Data.Net;

namespace CSI.Finance.MTD
{
    public interface IMTDVATAPIs
    {
        ICSIWebResponse RetrieveObligations(
            string apiUrl,
            string accessToken,
            string vrn,
            string startDate,
            string endDate,
            bool isWeb,
            string deviceId,
            string localIps,
            string localIpsTimestamp,
            string publicIp,
            string publicIpTimestamp,
            string publicPort,
            string screens,
            string timeZone,
            string userIds,
            string windowSize,
            string licenseIds,
            string productName,
            string vendorVersion,
            string doNotTrack,
            string userAgent,
            string plugins,
            string macAddresses,
            string status);

        ICSIWebResponse RetrievePayments(
            string apiUrl,
            string accessToken,
            string vrn,
            string startDate,
            string endDate,
            bool isWeb,
            string deviceId,
            string localIps,
            string localIpsTimestamp,
            string publicIp,
            string publicIpTimestamp,
            string publicPort,
            string screens,
            string timeZone,
            string userIds,
            string windowSize,
            string licenseIds,
            string productName,
            string vendorVersion,
            string doNotTrack,
            string userAgent,
            string plugins,
            string macAddresses);

        ICSIWebResponse SubmitReturn(
            string apiUrl,
            string accessToken,
            string vrn,
            bool isWeb,
            string deviceId,
            string localIps,
            string localIpsTimestamp,
            string publicIp,
            string publicIpTimestamp,
            string publicPort,
            string screens,
            string timeZone,
            string userIds,
            string windowSize,
            string licenseIds,
            string productName,
            string vendorVersion,
            string doNotTrack,
            string userAgent,
            string plugins,
            string macAddresses,
            string requestBody);

        ICSIWebResponse RetrieveLiabilities(
            string apiUrl,
            string accessToken,
            string vrn,
            string startDate,
            string endDate,
            bool isWeb,
            string deviceId,
            string localIps,
            string localIpsTimestamp,
            string publicIp,
            string publicIpTimestamp,
            string publicPort,
            string screens,
            string timeZone,
            string userIds,
            string windowSize,
            string licenseIds,
            string productName,
            string vendorVersion,
            string doNotTrack,
            string userAgent,
            string plugins,
            string macAddresses);

        ICSIWebResponse ValidateFraudPreventionHeaders(
            string apiUrl,
            string accessToken,
            string vrn,
            string startDate,
            string endDate,
            bool isWeb,
            string deviceId,
            string localIps,
            string localIpsTimestamp,
            string publicIp,
            string publicIpTimestamp,
            string publicPort,
            string screens,
            string timeZone,
            string userIds,
            string windowSize,
            string licenseIds,
            string productName,
            string vendorVersion,
            string doNotTrack,
            string userAgent,
            string plugins,
            string macAddresses);
    }
}