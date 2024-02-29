/*
 * agent/service.proto
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: version not set
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = agent.Client.OpenAPIDateConverter;

namespace agent.Model
{
    /// <summary>
    /// Defines agentSortOrder
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgentSortOrder
    {
        /// <summary>
        /// Enum DESC for value: DESC
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC = 1,

        /// <summary>
        /// Enum ASC for value: ASC
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC = 2
    }

}