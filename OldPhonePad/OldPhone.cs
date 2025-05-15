using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhonePad
{
    /// <summary>
    /// Contains logic for simulating an old mobile phone keypad.
    /// </summary>
    public class OldPhone
    {
        // Keypad mapping based on old phone layout for lookup 
        private static readonly Dictionary<char, string> keypad = new Dictionary<char, string>
        {
            { '1', "&'(" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };

        /// <summary>
        /// Converts the input string from the old phone pad into text.
        /// </summary>
        /// <param name="input">The string of keypad input ending with '#'.</param>
        /// <returns>The decoded string result.</returns>
        public static string OldPhonePadInput(string input)
        {
            var output = new StringBuilder();
            var currentSequence = new StringBuilder();

            foreach (char current in input)
            {
                switch (current)
                {
                    case '#':
                        // End of input, process remaining sequence if any
                        if (currentSequence.Length > 0)
                            output.Append(ProcessSequence(currentSequence.ToString()));
                        return output.ToString();

                    case '*':
                        // Backspace: clear current buffer or remove last character
                        if (currentSequence.Length > 0)
                            currentSequence.Clear();
                        else if (output.Length > 0)
                            output.Remove(output.Length - 1, 1);
                        break;

                    case ' ':
                        // Pause: finalize current sequence
                        if (currentSequence.Length > 0)
                        {
                            output.Append(ProcessSequence(currentSequence.ToString()));
                            currentSequence.Clear();
                        }
                        break;

                    default:
                        // Digits: accumulate or finalize sequence
                        if (char.IsDigit(current))
                        {
                            if (currentSequence.Length > 0 && currentSequence[0] != current)
                            {
                                output.Append(ProcessSequence(currentSequence.ToString()));
                                currentSequence.Clear();
                            }
                            currentSequence.Append(current);
                        }
                        break;
                }
            }

            return output.ToString();
        }

        /// <summary>
        /// Processes a sequence of repeated digits and returns the corresponding letter.
        /// </summary>
        /// <param name="sequence">The digit sequence (e.g., "7777").</param>
        /// <returns>The corresponding character.</returns>
        private static char ProcessSequence(string sequence)
        {
            if (string.IsNullOrEmpty(sequence))
                return '\0';

            char key = sequence[0];

            // Return unknown char for invalid keys
            if (!keypad.TryGetValue(key, out string letters))
                return '?';

            // Calculate index using modulo
            int index = (sequence.Length - 1) % letters.Length;
            return letters[index];
        }
    }
}
