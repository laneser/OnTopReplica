using System;
using System.Collections.Generic;
using System.Drawing;

namespace OnTopReplica {
    /// <summary>
    /// Represents a color that should be made transparent in the thumbnail.
    /// </summary>
    public class ColorKey {
        /// <summary>
        /// The color to make transparent
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Tolerance value for color matching (0-255)
        /// </summary>
        public int Tolerance { get; set; }

        /// <summary>
        /// Creates a new ColorKey with the specified color and default tolerance.
        /// </summary>
        public ColorKey(Color color, int tolerance = 10) {
            Color = color;
            Tolerance = Math.Max(0, Math.Min(255, tolerance));
        }

        /// <summary>
        /// Creates a ColorKey from a hex string (e.g., "#FF0000" or "FF0000")
        /// </summary>
        public static ColorKey FromHexString(string hexColor, int tolerance = 10) {
            if (string.IsNullOrEmpty(hexColor)) {
                throw new ArgumentNullException(nameof(hexColor));
            }

            if (hexColor.StartsWith("#")) {
                hexColor = hexColor.Substring(1);
            }

            try {
                int r = Convert.ToInt32(hexColor.Substring(0, 2), 16);
                int g = Convert.ToInt32(hexColor.Substring(2, 2), 16);
                int b = Convert.ToInt32(hexColor.Substring(4, 2), 16);
                
                return new ColorKey(Color.FromArgb(r, g, b), tolerance);
            }
            catch (Exception) {
                throw new FormatException("Invalid hex color format. Expected format: #RRGGBB or RRGGBB");
            }
        }

        /// <summary>
        /// Checks if the given color matches this color key within tolerance
        /// </summary>
        public bool MatchesColor(Color color) {
            return Math.Abs(color.R - Color.R) <= Tolerance &&
                   Math.Abs(color.G - Color.G) <= Tolerance &&
                   Math.Abs(color.B - Color.B) <= Tolerance;
        }

        public override string ToString() {
            return $"#{Color.R:X2}{Color.G:X2}{Color.B:X2} (Tolerance: {Tolerance})";
        }
    }
}