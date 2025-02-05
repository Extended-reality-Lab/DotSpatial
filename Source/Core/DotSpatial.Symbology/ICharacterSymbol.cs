// Copyright (c) DotSpatial Team. All rights reserved.
// Licensed under the MIT license. See License.txt file in the project root for full license information.

using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace DotSpatial.Symbology
{
    /// <summary>
    /// Interface for CharacterSymbol.
    /// </summary>
    public interface ICharacterSymbol : ISymbol, IColorable
    {
        #region Properties

        /// <summary>
        /// Gets the unicode category for this character.
        /// </summary>
        [Description("Gets the unicode category for this character.")]
        UnicodeCategory Category { get; }

        /// <summary>
        /// Gets or sets the character that this represents.
        /// </summary>
        [Description("Gets or sets the character for this symbol.")]
        char Character { get; set; }

        /// <summary>
        /// Gets or sets the character set. Unicode characters consist of 2 bytes. This represents the first byte,
        /// which can be thought of as specifying a typeset.
        /// </summary>
        [Description("Gets or sets the upper unicode byte, or character set.")]
        byte CharacterSet { get; set; }

        /// <summary>
        /// Gets or sets the byte code for the lower 256 values. This represents the
        /// specific character in a given "typeset" range.
        /// </summary>
        /// <remarks>
        /// [Editor(typeof(CharacterCodeEditor), typeof(UITypeEditor))].
        /// </remarks>
        [Description("Gets or sets the lower unicode byte or character ASCII code")]
        byte Code { get; set; }

        /// <summary>
        /// Gets or sets the string font family name to use for this character set.
        /// </summary>
        /// <remarks>[Editor(typeof(FontFamilyNameEditor), typeof(UITypeEditor))].</remarks>
        [Description("Gets or sets the font family name to use when building the font.")]
        string FontFamilyName { get; set; }

        /// <summary>
        /// Gets or sets the font style to use for this character layer.
        /// </summary>
        [Description("Gets or sets the font style to use for this character layer.")]
        FontStyle Style { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the string equivalent of the specified character code.
        /// </summary>
        /// <returns>A string version of the character.</returns>
        string ToString();

        #endregion
    }
}