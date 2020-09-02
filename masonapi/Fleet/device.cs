using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Mason.API.Fleet
{
    public class Device
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        [JsonPropertyName("self")]
        public string Self { get; set; }

        [JsonProperty("imei")]
        [JsonPropertyName("imei")]
        public string Imei { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("serialnumber")]
        [JsonPropertyName("serialnumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("apps")]
        [JsonPropertyName("apps")]
        public IList<ApplicationClass> Applications { get; set; }

        [JsonProperty("battery")]
        [JsonPropertyName("battery")]
        public BatteryClass Battery { get; set; }

        [JsonProperty("connection")]
        [JsonPropertyName("connection")]
        public ConnectionClass Connection { get; set; }

        [JsonProperty("createdAt")]
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("lastcheckin")]
        [JsonPropertyName("lastcheckin")]
        public DateTime LastCheckin { get; set; }

        [JsonProperty("family")]
        [JsonPropertyName("family")]
        public string Family { get; set; }

        [JsonProperty("group")]
        [JsonPropertyName("group")]
        public GroupClass Group { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public StatusClass Status { get; set; }

        [JsonProperty("os")]
        [JsonPropertyName("os")]
        public OperatingSystemClass OperatingSystem { get; set; }

        public class ApplicationClass
        {
            [JsonProperty("name")]
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonProperty("version")]
            [JsonPropertyName("version")]
            public string Version { get; set; }
        }

        public class BatteryClass
        {
            [JsonProperty("battery")]
            [JsonPropertyName("battery")]
            public string Level { get; set; }
        }

        public class ConnectionClass
        {
            [JsonProperty("dataUsage")]
            [JsonPropertyName("dataUsage")]
            public DataUsageClass DataUsage { get; set; }

            [JsonProperty("battery")]
            [JsonPropertyName("bluetooth")]
            public BluetoothClass Bluetooth { get; set; }

            [JsonProperty("sim")]
            [JsonPropertyName("sim")]
            public IList<SimClass> Sims { get; set; }

            [JsonProperty("wifi")]
            [JsonPropertyName("wifi")]
            public WifiClass Wifi { get; set; }
        }

        public class DataUsageClass
        {
            [JsonProperty("appDataUsage")]
            [JsonPropertyName("appDataUsage")]
            public AppDataUsageClass AppDataUsage { get; set; }
        }

        public class AppDataUsageClass
        {
            [JsonProperty("packageNames")]
            [JsonPropertyName("packageNames")]
            public IList<string> PackageNames { get; set; }

            [JsonProperty("uid")]
            [JsonPropertyName("uid")]
            public int Uid { get; set; }

            [JsonProperty("usageCycles")]
            [JsonPropertyName("usageCycles")]
            public IList<UsageCycleClass> UsageCycles { get; set; }
        }

        public class UsageCycleClass
        {
            [JsonProperty("startTime")]
            [JsonPropertyName("startTime")]
            public DateTime StartTime { get; set; }

            [JsonProperty("endTime")]
            [JsonPropertyName("endTime")]
            public DateTime EndTime { get; set; }

            [JsonProperty("usages")]
            [JsonPropertyName("usages")]
            public IList<UsageClass> Usages { get; set; }
        }

        public class UsageClass
        {
            [JsonProperty("type")]
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonProperty("bytesReceived")]
            [JsonPropertyName("bytesReceived")]
            public string ReceivesBytes { get; set; }

            [JsonProperty("bytesSend")]
            [JsonPropertyName("bytesSend")]
            public string SendBytes { get; set; }
        }

        public class BluetoothClass
        {
            [JsonProperty("enabled")]
            [JsonPropertyName("enabled")]
            public bool Enabled { get; set; }

            [JsonProperty("macAddress")]
            [JsonPropertyName("macAddress")]
            public string MacAddress { get; set; }

            [JsonProperty("name")]
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonProperty("pairedDevices")]
            [JsonPropertyName("pairedDevices")]
            public IList<string> PairedDevices { get; set; }
        }

        public class SimClass
        {
            [JsonProperty("carrier")]
            [JsonPropertyName("carrier")]
            public string Carrier { get; set; }

            [JsonProperty("countryiso")]
            [JsonPropertyName("countryiso")]
            public string CountryIso { get; set; }

            [JsonProperty("iccid")]
            [JsonPropertyName("iccid")]
            public string Iccid { get; set; }

            [JsonProperty("mcc")]
            [JsonPropertyName("mcc")]
            public string Mcc { get; set; }

            [JsonProperty("mnc")]
            [JsonPropertyName("mnc")]
            public string Mnc { get; set; }
        }

        public class WifiClass
        {
            [JsonProperty("adapterMacAddress")]
            [JsonPropertyName("adapterMacAddress")]
            public string AdapterMacAddress { get; set; }

            [JsonProperty("bssid")]
            [JsonPropertyName("bssid")]
            public string Bssid { get; set; }

            [JsonProperty("enabled")]
            [JsonPropertyName("enabled")]
            public bool Enabled { get; set; }

            [JsonProperty("ipaddress")]
            [JsonPropertyName("ipaddress")]
            public string Ipaddress { get; set; }

            [JsonProperty("ssid")]
            [JsonPropertyName("ssid")]
            public string Ssid { get; set; }
        }

        public class GroupClass
        {
            [JsonProperty("name")]
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonProperty("self")]
            [JsonPropertyName("self")]
            public string Self { get; set; }
        }

        public class OperatingSystemClass
        {
            [JsonProperty("configuration")]
            [JsonPropertyName("configuration")]
            public ConfigurationClass Configuration { get; set; }

            [JsonProperty("masonOS")]
            [JsonPropertyName("masonOS")]
            public MasonOsClass MasonOs { get; set; }
        }

        public class ConfigurationClass
        {
            [JsonProperty("device")]
            [JsonPropertyName("device")]
            public string Device { get; set; }

            [JsonProperty("product")]
            [JsonPropertyName("product")]
            public string Product { get; set; }

            [JsonProperty("project")]
            [JsonPropertyName("project")]
            public string Project { get; set; }

            [JsonProperty("version")]
            [JsonPropertyName("version")]
            public string Version { get; set; }
        }

        public class MasonOsClass
        {
            [JsonProperty("incremental")]
            [JsonPropertyName("incremental")]
            public string Incremental { get; set; }

            [JsonProperty("release")]
            [JsonPropertyName("release")]
            public string Release { get; set; }
        }

        public class StatusClass
        {
            [JsonProperty("osUpdated")]
            [JsonPropertyName("osUpdated")]
            public bool OsUpdated { get; set; }

            [JsonProperty("appsUpdated")]
            [JsonPropertyName("appsUpdated")]
            public bool ApplicationsUpdated { get; set; }

            [JsonProperty("projectUpdated")]
            [JsonPropertyName("projectUpdated")]
            public bool ProjectUpdated { get; set; }
        }
    }
}