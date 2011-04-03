using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Tariki.CompanyHouse.Api.Helpers
{
    /// <summary>
    /// Used to get around an issue to do with getting nullable values from XML 
    /// </summary>
    /// <remarks>
    /// http://stackoverflow.com/questions/306877/can-xmlserializer-deserialize-into-a-nullableint
    /// </remarks>
    /// <typeparam name="T"></typeparam>
    public abstract class Nullable<T> : IXmlSerializable
    {
        private T _value;
        private bool _hasValue;

        protected Nullable() { }

        protected Nullable(T value)
        {
            _hasValue = true;
            _value = value;
        }

        public bool HasValue
        {
            get { return _hasValue; }
        }

        public T Value
        {
            get
            {
                if (!_hasValue) throw new NoValueSetException();
                return _value;
            }
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            var item = reader.ReadElementContentAsString();

            if (reader.GetAttribute("nil") == "true" || string.IsNullOrEmpty(item))
            {
                ReadNullValue();
                return;
            }
            ReadNonNullValue(item);
        }

        void IXmlSerializable.WriteXml(XmlWriter writer)
        {
            throw new NotSupportedException();
        }


        private void ReadNullValue()
        {
            _hasValue = false;
        }

        private void ReadNonNullValue(string reader)
        {
            _value = RenderValue(reader);
            _hasValue = true;
        }

        protected abstract T RenderValue(string valueString);


    }

    internal class NoValueSetException : Exception { }

}