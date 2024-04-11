using System;
using System.Collections.Generic;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LangChain.Common.Converters
{
    public sealed class ObjectAsPrimitiveConverter : JsonConverter
    {
        FloatFormat FloatFormat { get; }
        UnknownNumberFormat UnknownNumberFormat { get; }
        ObjectFormat ObjectFormat { get; }

        public ObjectAsPrimitiveConverter() : this(FloatFormat.Double, UnknownNumberFormat.Error, ObjectFormat.Expando) { }

        public ObjectAsPrimitiveConverter(FloatFormat floatFormat, UnknownNumberFormat unknownNumberFormat, ObjectFormat objectFormat)
        {
            FloatFormat = floatFormat;
            UnknownNumberFormat = unknownNumberFormat;
            ObjectFormat = objectFormat;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                JToken t = JToken.FromObject(value);
                t.WriteTo(writer);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            return ConvertTokenToObject(token);
        }

        private object ConvertTokenToObject(JToken token)
        {
            switch (token.Type)
            {
                case JTokenType.Object:
                    return token.ToObject<IDictionary<string, object>>();
                case JTokenType.Array:
                    return token.ToObject<List<object>>();
                case JTokenType.Integer:
                    return token.ToObject<int>();
                case JTokenType.Float:
                    return FloatFormat == FloatFormat.Decimal ? token.ToObject<decimal>() : token.ToObject<double>();
                case JTokenType.String:
                    return token.ToString();
                case JTokenType.Boolean:
                    return token.ToObject<bool>();
                case JTokenType.Null:
                    return null;
                default:
                    throw new JsonException($"Unexpected token type: {token.Type}");
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return true; // Can handle all types
        }
    }

    public enum FloatFormat
    {
        Double,
        Decimal
    }

    public enum UnknownNumberFormat
    {
        Error,
        JsonElement,
    }

    public enum ObjectFormat
    {
        Expando,
        Dictionary,
    }
}
