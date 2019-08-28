using System;

namespace NumberToWordConverter
{
    /// <summary>
    /// This class convert number range between -999999999 to 999999999 in text
    /// </summary>
    public sealed class NumberToText
    {
        /// <summary>
        /// Recursive method calling for number to text conversion
        /// </summary>
        /// <param name="numberValueToText"></param>
        /// <returns>string</returns>
        public static string ConvertNumberToText(string numberValueToText)
        {
            string _numberWords = string.Empty;
            try
            {
                bool _beginsWithZero = false;
                bool _isCompleted = false;
                double _number = Convert.ToDouble(numberValueToText);
                if (_number > 0)
                {
                    _beginsWithZero = numberValueToText.StartsWith("0");
                    int _numberLength = numberValueToText.Length;
                    int _position = 0;
                    string _numberAtPlace = "";
                    switch (_numberLength)
                    {
                        case 1://face value ones'
                            _numberWords = PlaceValueOfOnes(numberValueToText);
                            _isCompleted = true;
                            break;

                        case 2://face value tens'
                            _numberWords = PlaceValueOfTens(numberValueToText);
                            _isCompleted = true;
                            break;

                        case 3://face value hundreds'
                            _position = (_numberLength % 3) + 1;
                            _numberAtPlace = " hundred ";
                            break;

                        case 4://face value  thousands'
                        case 5:
                        case 6:
                            _position = (_numberLength % 4) + 1;
                            _numberAtPlace = " thousand ";
                            break;

                        case 7://face value  millions'
                        case 8:
                        case 9:
                            _position = (_numberLength % 7) + 1;
                            _numberAtPlace = " million ";
                            break;

                        case 10://face value  Billions's
                        case 11:
                        case 12:

                            _position = (_numberLength % 10) + 1;
                            _numberAtPlace = " billion ";
                            break;

                        default:
                            _isCompleted = true;
                            break;
                    }
                    if (!_isCompleted)
                    {
                        if (numberValueToText.Substring(0, _position) != "0" && numberValueToText.Substring(_position) != "0")
                            try
                            {
                                _numberWords = ConvertNumberToText(numberValueToText.Substring(0, _position)) + _numberAtPlace + ConvertNumberToText(numberValueToText.Substring(_position));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        else
                            _numberWords = ConvertNumberToText(numberValueToText.Substring(0, _position)) + ConvertNumberToText(numberValueToText.Substring(_position));
                    }
                    if (_numberWords.Trim().Equals(_numberAtPlace.Trim()))
                        _numberWords = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _numberWords.Trim();
        }
        /// <summary>
        /// Get place values of the number with tens
        /// </summary>
        /// <param name="number">string</param>
        /// <returns>string</returns>
        private static string PlaceValueOfTens(string number)
        {
            int _Number = Convert.ToInt32(number);
            string _nameOfDigit = string.Empty;
            switch (_Number)
            {
                case 10:
                    _nameOfDigit = "ten";
                    break;

                case 11:
                    _nameOfDigit = "eleven";
                    break;

                case 12:
                    _nameOfDigit = "twelve";
                    break;

                case 13:
                    _nameOfDigit = "thirteen";
                    break;

                case 14:
                    _nameOfDigit = "fourteen";
                    break;

                case 15:
                    _nameOfDigit = "fifteen";
                    break;

                case 16:
                    _nameOfDigit = "sixteen";
                    break;

                case 17:
                    _nameOfDigit = "seventeen";
                    break;

                case 18:
                    _nameOfDigit = "eighteen";
                    break;

                case 19:
                    _nameOfDigit = "nineteen";
                    break;

                case 20:
                    _nameOfDigit = "twenty";
                    break;

                case 30:
                    _nameOfDigit = "thirty";
                    break;

                case 40:
                    _nameOfDigit = "fourty";
                    break;

                case 50:
                    _nameOfDigit = "fifty";
                    break;

                case 60:
                    _nameOfDigit = "sixty";
                    break;

                case 70:
                    _nameOfDigit = "seventy";
                    break;

                case 80:
                    _nameOfDigit = "eighty";
                    break;

                case 90:
                    _nameOfDigit = "ninety";
                    break;

                default:
                    if (_Number > 0)
                        _nameOfDigit = PlaceValueOfTens(number.Substring(0, 1) + "0") + " " + PlaceValueOfOnes(number.Substring(1));
                    break;
            }
            return _nameOfDigit;
        }
        /// <summary>
        /// Get place values of the number with Ones
        /// </summary>
        /// <param name="number">string</param>
        /// <returns>string</returns>
        private static string PlaceValueOfOnes(string number)
        {
            int _Number = Convert.ToInt32(number);
            string _nameOfDigit = "";
            switch (_Number)
            {
                case 1:
                    _nameOfDigit = "one";
                    break;

                case 2:
                    _nameOfDigit = "two";
                    break;

                case 3:
                    _nameOfDigit = "three";
                    break;

                case 4:
                    _nameOfDigit = "four";
                    break;

                case 5:
                    _nameOfDigit = "five";
                    break;

                case 6:
                    _nameOfDigit = "six";
                    break;

                case 7:
                    _nameOfDigit = "seven";
                    break;

                case 8:
                    _nameOfDigit = "eight";
                    break;

                case 9:
                    _nameOfDigit = "nine";
                    break;
            }
            return _nameOfDigit;
        }
    }
}
