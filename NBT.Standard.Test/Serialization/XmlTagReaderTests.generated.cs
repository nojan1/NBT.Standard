﻿﻿﻿﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.IO;
using Xunit;
using NBT.Serialization;

namespace NBT.Test.Serialization
{
  partial class XmlTagReaderTests
  {
    [Fact]
    public void ReadByte_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        byte expected;
        byte actual;

        writer = this.CreateWriter(stream);

        expected = (byte)(byte.MaxValue >> 1);

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadByte();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_byte_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        byte expected1;
        byte expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = (byte)(byte.MaxValue >> 1);
        expected2 = 63;

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.Byte, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

    [Fact]
    public void ReadShort_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        short expected;
        short actual;

        writer = this.CreateWriter(stream);

        expected = (short)(short.MaxValue >> 1);

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadShort();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_short_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        short expected1;
        short expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = (short)(short.MaxValue >> 1);
        expected2 = 8191;

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.Short, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

    [Fact]
    public void ReadInt_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        int expected;
        int actual;

        writer = this.CreateWriter(stream);

        expected = 1073741823;

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadInt();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_int_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        int expected1;
        int expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = 1073741823;
        expected2 = 536870911;

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.Int, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

    [Fact]
    public void ReadLong_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        long expected;
        long actual;

        writer = this.CreateWriter(stream);

        expected = 4611686018427387903;

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadLong();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_long_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        long expected1;
        long expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = 4611686018427387903;
        expected2 = 2305843009213693951;

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.Long, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

    [Fact]
    public void ReadFloat_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        float expected;
        float actual;

        writer = this.CreateWriter(stream);

        expected = 1.701412E+38F;

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadFloat();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_float_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        float expected1;
        float expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = 1.701412E+38F;
        expected2 = 1.134274E+38F;

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.Float, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

    [Fact]
    public void ReadDouble_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        double expected;
        double actual;

        writer = this.CreateWriter(stream);

        expected = 8.98846567431158E+307;

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadDouble();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_double_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        double expected1;
        double expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = 8.98846567431158E+307;
        expected2 = 5.99231044954105E+307;

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.Double, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

    [Fact]
    public void ReadByteArray_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        byte[] expected;
        byte[] actual;

        writer = this.CreateWriter(stream);

        expected = new byte[] { 2, 4, 8, 16, 32, 64, 128 };

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadByteArray();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_bytearray_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        byte[] expected1;
        byte[] expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = new byte[] { 2, 4, 8, 16, 32, 64, 128 };
        expected2 = new byte[] { 2, 4, 8, 16, 32, 48, 128 };

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.ByteArray, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

    [Fact]
    public void ReadString_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        string expected;
        string actual;

        writer = this.CreateWriter(stream);

        expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadString();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_string_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        string expected1;
        string expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";
        expected2 = "DIFFERENT";

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.String, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

    [Fact]
    public void ReadList_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        TagCollection expected;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 256 };

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_list_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        TagCollection expected1;
        TagCollection expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 256 };
        expected2 = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 255 };

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.List, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

    [Fact]
    public void ReadCompound_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        TagDictionary expected;
        TagDictionary actual;

        writer = this.CreateWriter(stream);

        expected = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 8) };

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadCompound();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_compound_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        TagDictionary expected1;
        TagDictionary expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 8) };
        expected2 = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 16) };

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.Compound, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

    [Fact]
    public void ReadIntArray_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        int[] expected;
        int[] actual;

        writer = this.CreateWriter(stream);

        expected = new[] { 2190, 2994, 3248, 4294394 };

        writer.WriteStartDocument();
        writer.WriteTag("value", expected);
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadIntArray();

        // assert
        Assert.Equal(expected, actual);
      }
    }

    [Fact]
    public void ReadList_of_intarray_test()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagReader reader;
        TagWriter writer;
        int[] expected1;
        int[] expected2;
        TagCollection actual;

        writer = this.CreateWriter(stream);

        expected1 = new[] { 2190, 2994, 3248, 4294394 };
        expected2 = new[] { 2190, 2994, 3248, 294394 };

        writer.WriteStartDocument();
        writer.WriteStartTag("list", TagType.List, TagType.IntArray, 2);
        writer.WriteTag(expected1);
        writer.WriteTag(expected2);
        writer.WriteEndTag();
        writer.WriteEndDocument();

        stream.Position = 0;

        reader = this.CreateReader(stream);
        reader.ReadTagType();
        reader.ReadTagName();

        // act
        actual = reader.ReadList();

        // assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected1, actual[0].GetValue());
        Assert.Equal(expected2, actual[1].GetValue());
      }
    }

  }
}