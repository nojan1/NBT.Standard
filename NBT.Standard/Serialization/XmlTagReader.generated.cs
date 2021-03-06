﻿﻿﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace NBT.Serialization
{
  partial class XmlTagReader
  {
    private static readonly IDictionary<string, TagType> _tagTypeEnumLookup;

    static XmlTagReader()
    {
      // as the values shouldn't be in upper case anyway, hopefully the Turkish I won't trigger
      _tagTypeEnumLookup = new Dictionary<string, TagType>(StringComparer.OrdinalIgnoreCase)
      {
        { "Byte", TagType.Byte },
        { "Short", TagType.Short },
        { "Int", TagType.Int },
        { "Long", TagType.Long },
        { "Float", TagType.Float },
        { "Double", TagType.Double },
        { "ByteArray", TagType.ByteArray },
        { "String", TagType.String },
        { "List", TagType.List },
        { "Compound", TagType.Compound },
        { "IntArray", TagType.IntArray },
      };
    }
  }
}