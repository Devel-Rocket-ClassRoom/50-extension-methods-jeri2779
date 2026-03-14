using System;

// README.md를 읽고 코드를 작성하세요.



public static class StringExtensions
{
    public static bool IsPalindrome(this string str)
    {
        //  null / 빈 문자열 guard clause 처리
        //└─ null이나 ""이면 즉시 false 반환
        if (string.IsNullOrEmpty(str))
        {
            return false;
        }

        // 대칭 비교를 위한 인덱스 설정
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            // 좌우 문자가 다르면 false
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
//public static class Palindrome
//{
//    public static bool IsPalindrome(string input)
//    {
//        // 입력 문자열을 소문자로 변환하고 공백을 제거합니다.
//        string processedInput = input.ToLower().Replace(" ", "");

//        // 문자열의 길이를 구합니다.
//        int length = processedInput.Length;

//        // 문자열의 절반까지만 비교합니다.
//        for (int i = 0; i < length / 2; i++)
//        {
//            if (processedInput[i] != processedInput[length - 1 - i])
//            {
//                return false; // 일치하지 않으면 회문이 아닙니다.
//            }
//        }

//        return true; // 모든 문자가 일치하면 회문입니다.
//    }
//}
