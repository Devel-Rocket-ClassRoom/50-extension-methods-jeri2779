using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

// README.md를 읽고 코드를 작성하세요.t
try
{
List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<string> cards = new() { "♠A", "♥K", "♦Q", "♣J" };
string[] students = { "김철수", "이영희", "박민수", "최지연", "정우진" };

Console.WriteLine("== 컬렉션 셔플 테스트 ===");
Console.WriteLine($"원본: {string.Join(", ", numbers)}");
numbers.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", numbers)}");
Console.WriteLine();

Console.WriteLine("[카드 덱 셔플]");
Console.WriteLine($"원본: {string.Join(", ", cards)}");
cards.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", cards)}");
Console.WriteLine();

Console.WriteLine("[학생 순서 무작위 배치]");
Console.WriteLine($"원본: {string.Join(", ", students)}");
students.Shuffle();
Console.WriteLine($"셔플: {string.Join(", ", students)}");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"오류 발생: {ex.Message}");
}


public static class CollectionExtensions
{

    public static void Shuffle<T>(this IList<T> list)
       
    {
        if(list == null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        Random random = Random.Shared;// C# 9.0에서 도입된 Random.Shared는 스레드 안전한 단일 인스턴스 Random 객체를 제공합니다.
        int n = list.Count;// 리스트의 요소 수 저장

        for (int i  = n -1; i > 0; i--)
        {
            int j = random.Next(i + 1);

            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}