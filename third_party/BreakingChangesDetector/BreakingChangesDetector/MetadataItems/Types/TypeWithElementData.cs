﻿/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using Microsoft.CodeAnalysis;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Abstract base sealed class representing the metadata for an externally visible type with an element type, which is either an array or pointer type.
    /// </summary>
    public abstract class TypeWithElementData : TypeData
    {
        internal TypeWithElementData(string name, Accessibility accessibility, MemberFlags memberFlags, TypeKind typeKind, TypeData elementType)
            : base(name, accessibility, memberFlags, typeKind) =>
            ElementType = elementType;

        /// <inheritdoc/>
        public override void Accept(MetadataItemVisitor visitor) => visitor.VisitTypeWithElementData(this);

        /// <inheritdoc/>
        public override AssemblyData AssemblyData => ElementType.AssemblyData;

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as TypeWithElementData;
            if (otherTyped == null)
            {
                return false;
            }

            if (ElementType.DisplayName != otherTyped.ElementType.DisplayName)
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc/>
        internal override AssemblyFamily GetDefiningAssemblyFamily() => ElementType.GetDefiningAssemblyFamily();

        /// <inheritdoc/>
        internal override string GetNamespaceName() => ElementType.GetNamespaceName();

        /// <inheritdoc/>
        internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
        {
            if (base.IsEquivalentToNewMember(newMember, newAssemblyFamily) == false)
            {
                return false;
            }

            return
                newMember is TypeWithElementData other &&
                ElementType.IsEquivalentToNew(other.ElementType, newAssemblyFamily);
        }

        /// <summary>
        /// Gets the underlying element type.
        /// </summary>
        public TypeData ElementType { get; } // TODO_Serialize: Round trip and unit test
    }
}
