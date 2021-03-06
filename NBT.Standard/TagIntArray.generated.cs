﻿﻿﻿﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Globalization;

namespace NBT
{
  public partial class TagIntArray : Tag, IEquatable<TagIntArray>
  {
    #region Constants

    internal static readonly int[] EmptyValue = new int[0];

    #endregion

    #region Fields

    private int[] _value;

    #endregion

    #region Constructors

    public TagIntArray()
      : this(string.Empty, EmptyValue)
    { }

    public TagIntArray(string name)
      : this(name, EmptyValue)
    { }

    public TagIntArray(int[] value)
      : this(string.Empty, value)
    { }

    public TagIntArray(string name, int[] value)
      : base(name)
    {
      _value = value;
    }

    #endregion

    #region Properties

    public override TagType Type
    {
      get { return TagType.IntArray; }
    }

    public int[] Value
    {
      get { return _value; }
      set { _value = value; }
    }

    #endregion

    #region Methods

    public override int GetHashCode()
    {
      // http://stackoverflow.com/a/263416/148962

      unchecked // Overflow is fine, just wrap
      {
        int hash;

        hash = 17;
        hash = hash * 23 + this.Name.GetHashCode();

        if(_value != null)
        {
          for(int i = 0; i < _value.Length; i++)
          {
            hash = hash * 23 + _value[i].GetHashCode();
          }
        }

        return hash;
      }
    }

    public override object GetValue()
    {
      return _value;
    }

    public override void SetValue(object value)
    {
      _value = (int[])value;
    }

    public override string ToString()
    {
      int count;

      count = _value?.Length ?? 0;

      return string.Concat("[", this.Type, ": ", this.Name, "] (", count.ToString(CultureInfo.InvariantCulture), " items)");
    }

    #endregion

    #region IEquatable<TagIntArray> Interface

    public bool Equals(TagIntArray other)
    {
      bool result;

      result = !ReferenceEquals(null, other);

      if (result && !ReferenceEquals(this, other))
      {
        result = string.Equals(this.Name, other.Name);

        if (result)
        {
          int[] dst;

          dst = other.Value;

          result = _value == null && dst == null || _value != null && dst != null && _value.Length == dst.Length;

          if (result && _value != null && dst != null)
          {
            // ReSharper disable once LoopCanBeConvertedToQuery
            for (int i = 0; i < _value.Length; i++)
            {
              if (_value[i] != dst[i])
              {
                result = false;
                break;
              }
            }
          }
        }
      }

      return result;
    }

    #endregion
  }
}