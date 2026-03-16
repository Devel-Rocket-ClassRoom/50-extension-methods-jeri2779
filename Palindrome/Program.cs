using System;

// README.m
Console.WriteLine("=== 회문 판별 테스트 ===");

 
string[] testCases = {
            "토마토",
            "기러기",
            "level",
            "Level",
            "A man, a plan, a canal: Panama",
            "race a car",
            "hello",
            "가나다",
            ""
        };
foreach (string testCase in testCases)
{
    bool result = testCase.IsPalindrome();
    Console.WriteLine($"{testCase} -> {result}");
}




public static class StringExtensions
{
    public static bool IsPalindrome(this string str)
    {
        
        
        if (string.IsNullOrEmpty(str)) return false;  


        // 대칭 비교를 위한 인덱스 설정
        int left = 0;
        int right = str.Length - 1;
        bool hasvalidchar = false;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(str[left]))
            //└─  left 인덱스 이동
            {
                left++;
            }
            while (left < right && !char.IsLetterOrDigit(str[right]))
            //└─  right 인덱스 이동
            {
                right--;
            }
            // 좌우 문자가 다르면 false
            if (left < right)
            {
                hasvalidchar = true;
                if (char.ToLower(str[left]) != char.ToLower(str[right]))
                //└─ 대소문자 구분 없이 비교
                {
                    return false;//└─ 좌우 문자가 다르면 회문x
                }
                left++;
                right--;
            }

        }
        // 유효한 문자가 하나도 없으면 false
        return hasvalidchar; //└─ 모든 유효한 문자가 대칭이면 true 반환
    }
}
 