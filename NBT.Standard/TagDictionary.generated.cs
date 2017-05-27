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

namespace NBT
{
  partial class TagDictionary
  {
    /// <summary>
    /// Creates and adds a new <see cref="TagByte"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagByte"/> containing the specified name and value.
    /// </returns>
    public TagByte Add(string name, byte value)
    {
      TagByte tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

    /// <summary>
    /// Creates and adds a new <see cref="TagShort"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagShort"/> containing the specified name and value.
    /// </returns>
    public TagShort Add(string name, short value)
    {
      TagShort tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

    /// <summary>
    /// Creates and adds a new <see cref="TagInt"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagInt"/> containing the specified name and value.
    /// </returns>
    public TagInt Add(string name, int value)
    {
      TagInt tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

    /// <summary>
    /// Creates and adds a new <see cref="TagLong"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagLong"/> containing the specified name and value.
    /// </returns>
    public TagLong Add(string name, long value)
    {
      TagLong tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

    /// <summary>
    /// Creates and adds a new <see cref="TagFloat"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagFloat"/> containing the specified name and value.
    /// </returns>
    public TagFloat Add(string name, float value)
    {
      TagFloat tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

    /// <summary>
    /// Creates and adds a new <see cref="TagDouble"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagDouble"/> containing the specified name and value.
    /// </returns>
    public TagDouble Add(string name, double value)
    {
      TagDouble tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

    /// <summary>
    /// Creates and adds a new <see cref="TagByteArray"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagByteArray"/> containing the specified name and value.
    /// </returns>
    public TagByteArray Add(string name, byte[] value)
    {
      TagByteArray tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

    /// <summary>
    /// Creates and adds a new <see cref="TagString"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagString"/> containing the specified name and value.
    /// </returns>
    public TagString Add(string name, string value)
    {
      TagString tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

    /// <summary>
    /// Creates and adds a new <see cref="TagList"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagList"/> containing the specified name and value.
    /// </returns>
    public TagList Add(string name, TagCollection value)
    {
      TagList tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

    /// <summary>
    /// Creates and adds a new <see cref="TagCompound"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagCompound"/> containing the specified name and value.
    /// </returns>
    public TagCompound Add(string name, TagDictionary value)
    {
      TagCompound tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

    /// <summary>
    /// Creates and adds a new <see cref="TagIntArray"/> with the specified name and value.
    /// </summary>
    /// <param name="name">The name of the tag to add.</param>
    /// <param name="value">The value of the tag.</param>
    /// <returns>
    /// A <see cref="TagIntArray"/> containing the specified name and value.
    /// </returns>
    public TagIntArray Add(string name, int[] value)
    {
      TagIntArray tag;

      tag = TagFactory.CreateTag(name, value);

      this.Add(tag);

      return tag;
    }

  }
}