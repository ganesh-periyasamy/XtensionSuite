// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;

namespace Nallenthal.Common.XtensionSuite.AssertXtensions
{
    /// <summary>
    /// This class contains set of extension methods to ascertain value of a given <see cref="string"/>
    /// These can be used for unit tests and in general validations.
    /// </summary>
    public static class StringAssertXtensions
    {
        /// <summary>
        /// Ensures that the first string is equal to the second string.
        /// Checks the two given strings and throws a <see cref="ValueMismatchException{T}"/> if the first string is NOT equal to the second string.
        /// </summary>
        /// <param name="firstString">The given first string.</param>
        /// <param name="secondString">The second string to be compared.</param>
        public static void ShouldBeEqualTo(this string firstString, string secondString)
        {
            if (string.Compare(firstString, secondString) != 0)
            {
                throw new ValueMismatchException<string>(secondString, firstString);
            }
        }
    }

    /// <summary>
    /// This Namespace contains BDD style extension methods for <see cref="string"/>
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc
    {
    }
}
