using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OnTopReplica {
    /// <summary>
    /// Manages a collection of color keys for chroma keying in the thumbnail.
    /// </summary>
    public class ColorKeyCollection {
        private List<ColorKey> _colorKeys = new List<ColorKey>();

        /// <summary>
        /// Gets the list of color keys.
        /// </summary>
        public List<ColorKey> ColorKeys => _colorKeys;

        /// <summary>
        /// Adds a new color key to the collection.
        /// </summary>
        public void Add(ColorKey colorKey) {
            if (colorKey != null) {
                _colorKeys.Add(colorKey);
            }
        }

        /// <summary>
        /// Adds a new color key from a hex color string.
        /// </summary>
        public void AddFromHex(string hexColor, int tolerance = 10) {
            try {
                Add(ColorKey.FromHexString(hexColor, tolerance));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error adding color key", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Removes a color key at the specified index.
        /// </summary>
        public void RemoveAt(int index) {
            if (index >= 0 && index < _colorKeys.Count) {
                _colorKeys.RemoveAt(index);
            }
        }

        /// <summary>
        /// Clears all color keys.
        /// </summary>
        public void Clear() {
            _colorKeys.Clear();
        }

        /// <summary>
        /// Checks if any of the color keys matches the given color.
        /// </summary>
        public bool IsColorMatched(Color color) {
            foreach (var colorKey in _colorKeys) {
                if (colorKey.MatchesColor(color)) {
                    return true;
                }
            }
            return false;
        }
    }
}