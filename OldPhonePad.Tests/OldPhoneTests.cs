using Xunit;
using OldPhonePad;

namespace OldPhonePad.Tests
{
    /// <summary>
    /// Contains unit tests for OldPhonePadInput method.
    /// </summary>
    public class OldPhoneTests
    {
        /// <summary>
        /// Verifies various scenarios of keypad input.
        /// </summary>
        [Theory]
        [InlineData("33#", "E")]                      // Basic input
        [InlineData("227*#", "B")]                    // Backspace
        [InlineData("4433555 555666#", "HELLO")]      // Proper spaced message
        [InlineData("8 88777444666*664#", "????")]    // Invalid/broken sequence
        [InlineData("777733 6660 555666096667775553#", "SECRETMESSAGE")]  // Longer message
        public void TestOldPhonePadInput(string input, string expected)
        {
            string result = OldPhone.OldPhonePadInput(input);
            Assert.Equal(expected, result);
        }
    }
}
