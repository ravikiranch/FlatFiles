﻿using System;
using System.Reflection;

namespace FlatFiles.TypeMapping
{
    /// <summary>
    /// Represents the mapping from a type property to a Boolean column.
    /// </summary>
    public interface IIgnoredMapping
    {
        /// <summary>
        /// Sets the name of the column in the input or output file.
        /// </summary>
        /// <param name="name">The name of the column.</param>
        /// <returns>The property mapping for further configuration.</returns>
        IIgnoredMapping ColumnName(string name);
    }

    internal sealed class IgnoredMapping : IIgnoredMapping, IPropertyMapping
    {
        private readonly IgnoredColumn column;

        public IgnoredMapping(IgnoredColumn column)
        {
            this.column = column;
        }

        public IIgnoredMapping ColumnName(string name)
        {
            this.column.ColumnName = name;
            return this;
        }

        public PropertyInfo Property
        {
            get { return null; }
        }

        public IColumnDefinition ColumnDefinition
        {
            get { return column; }
        }
    }
}
