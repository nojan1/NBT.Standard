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
using Xunit;

namespace NBT.Test
{
  partial class TagCollectionTests
  {
    [Fact]
    public void Add_adds_unnamed_byte()
    {
      // arrange
      TagCollection target;
      TagByte actual;
      byte expected;

      expected = (byte)(byte.MaxValue >> 1);

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_byte_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = (byte)(byte.MaxValue >> 1);

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

        [Fact]
    public void Add_adds_unnamed_short()
    {
      // arrange
      TagCollection target;
      TagShort actual;
      short expected;

      expected = (short)(short.MaxValue >> 1);

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_short_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = (short)(short.MaxValue >> 1);

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

        [Fact]
    public void Add_adds_unnamed_int()
    {
      // arrange
      TagCollection target;
      TagInt actual;
      int expected;

      expected = 1073741823;

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_int_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = 1073741823;

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

        [Fact]
    public void Add_adds_unnamed_long()
    {
      // arrange
      TagCollection target;
      TagLong actual;
      long expected;

      expected = 4611686018427387903;

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_long_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = 4611686018427387903;

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

        [Fact]
    public void Add_adds_unnamed_float()
    {
      // arrange
      TagCollection target;
      TagFloat actual;
      float expected;

      expected = 1.701412E+38F;

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_float_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = 1.701412E+38F;

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

        [Fact]
    public void Add_adds_unnamed_double()
    {
      // arrange
      TagCollection target;
      TagDouble actual;
      double expected;

      expected = 8.98846567431158E+307;

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_double_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = 8.98846567431158E+307;

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

        [Fact]
    public void Add_adds_unnamed_bytearray()
    {
      // arrange
      TagCollection target;
      TagByteArray actual;
      byte[] expected;

      expected = new byte[] { 2, 4, 8, 16, 32, 64, 128 };

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_bytearray_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = new byte[] { 2, 4, 8, 16, 32, 64, 128 };

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

        [Fact]
    public void Add_adds_unnamed_string()
    {
      // arrange
      TagCollection target;
      TagString actual;
      string expected;

      expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_string_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

        [Fact]
    public void Add_adds_unnamed_list()
    {
      // arrange
      TagCollection target;
      TagList actual;
      TagCollection expected;

      expected = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 256 };

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_list_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 256 };

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

        [Fact]
    public void Add_adds_unnamed_compound()
    {
      // arrange
      TagCollection target;
      TagCompound actual;
      TagDictionary expected;

      expected = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 8) };

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_compound_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 8) };

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

        [Fact]
    public void Add_adds_unnamed_intarray()
    {
      // arrange
      TagCollection target;
      TagIntArray actual;
      int[] expected;

      expected = new[] { 2190, 2994, 3248, 4294394 };

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.Value);
    }

    [Fact]
    public void Add_adds_unnamed_intarray_object()
    {
      // arrange
      TagCollection target;
      Tag actual;
      object expected;

      expected = new[] { 2190, 2994, 3248, 4294394 };

      target = new TagCollection();

      // act
      actual = target.Add(expected);

      // assert
      Assert.NotNull(actual);
      Assert.True(target.Contains(actual));
      Assert.Empty(actual.Name);
      Assert.Equal(expected, actual.GetValue());
    }

      }
}