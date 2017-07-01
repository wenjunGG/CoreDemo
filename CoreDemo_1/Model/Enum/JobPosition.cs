using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobPosition
    {
        Trainee,
        Junior,
        Senior,
        Expert,
        Manager
    }
}
