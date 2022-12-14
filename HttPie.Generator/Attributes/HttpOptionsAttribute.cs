using System;
using System.Net.Mime;
using HttPie.Enums;

namespace HttPie.Attributes;

[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class)]
public sealed class HttpOptionsAttribute : Attribute
{
    public string BaseUrl { get; }
    public Casing PathCasing { get; set; }
    public Casing QueryCasing { get; set; }
    public Casing PropertyCasing { get;set; }
    public Casing EnumQueryCasing { get; set; }
    public Casing EnumSerializationCasing { get; set; }
    public BodyType DefaultBodyType { get; set; } = BodyType.Json;
    public ResponseType DefaultResponseType { get;set; } = ResponseType.Json;

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
    public HttpOptionsAttribute(string baseUrl)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
    {
        BaseUrl = baseUrl;
    }
}