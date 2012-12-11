using System;

namespace SharpVectors.Dom.Svg
{
	/// <summary>
	/// Used for attributes of basic type 'length' which can be 
	/// animated. 
	/// </summary>
	/// <developer>niklas@protocol7.com</developer>
	/// <developer>kevin@kevlindev.com</developer>
	/// <completed>100</completed>
	public class SvgAnimatedLength : ISvgAnimatedLength
	{
        #region Private Fields
        private SvgLength baseVal;
        private SvgLength animVal;
		#endregion

		#region Constructors
		/// <summary>
		/// Used for attributes of basic type 'length' which can be animated. 
		/// </summary>
		/// <param name="stringValue">String to parse for the value</param>
		/// <param name="ownerElement">The elements that contains the length</param>
		/// <param name="direction">The direction of the length, 0=x-axis, 1=y-axis, 2=no special axis</param>
		public SvgAnimatedLength(string propertyName, string stringValue, SvgElement ownerElement, SvgLengthDirection direction)
		{
			baseVal = new SvgLength(propertyName, stringValue, ownerElement, direction);
			animVal = baseVal;
		}

		public SvgAnimatedLength(string propertyName, string stringValue, string defaultValue, SvgElement ownerElement, SvgLengthDirection direction)
		{
			baseVal = new SvgLength(propertyName, stringValue, defaultValue, ownerElement, direction);
			animVal = baseVal;
		}
		#endregion

        #region ISvgAnimatedLength Interface
		/// <summary>
		/// The base value of the given attribute before applying any animations.
		/// </summary>
		public ISvgLength BaseVal
		{
			get
			{
				return baseVal;
			}
		}
		
		/// <summary>
		/// If the given attribute or property is being animated, contains the current animated value of the attribute or property, and both the object itself and its contents are readonly. If the given attribute or property is not currently being animated, contains the same value as 'baseVal'. 
		/// </summary>
		public ISvgLength AnimVal
		{
			get
			{
				return animVal;
			}
		}
		#endregion
	}
}
