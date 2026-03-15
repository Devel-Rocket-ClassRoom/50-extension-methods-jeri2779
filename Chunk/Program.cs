using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

using System;
using System.Collections.Generic;
using System.Linq;

 
        Console.WriteLine("=== 컬렉션 청킹 테스트 ===\n");

        // 1. 숫자를 3개씩 그룹화
        Console.WriteLine("[숫자를 3개씩 그룹화]");
        var numbers = Enumerable.Range(1, 10); // 1부터 10까지 생성
        foreach (var group in numbers.Chunk(3))
        {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }

        // 2. 학생들을 2명씩 팀 구성
        Console.WriteLine("\n[학생들을 2명씩 팀 구성]");
        var students = new List<string> { "김철수", "이영희", "박민수", "최지연", "정우진" };
        int teamNumber = 1;
        foreach (var team in students.Chunk(2))
        {
            Console.WriteLine($"팀 {teamNumber++}: {string.Join(", ", team)}");
        }

        // 3. 페이지별로 5개씩 나누기
        Console.WriteLine("\n[페이지별로 5개씩 나누기]");
        var pages = Enumerable.Range(1, 25);
        int pageNumber = 1;
        foreach (var page in pages.Chunk(5))
        {
            Console.WriteLine($"페이지 {pageNumber++}: {string.Join(", ", page)}");
        }
 


public static class ChunkExtensions
{
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source , int size)
    {
        if (size <= 0)
        {
            throw new ArgumentException("청크 크기는 1 이상어야 합니다.", nameof(size));
        }
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));


        }
        return ChunkIterator(source, size);
        
    }

    public static IEnumerable<IEnumerable<T>> ChunkIterator<T>(this IEnumerable<T> source, int size)
    {
        List<T> chunk = new List<T>(size);

        foreach(var item in source)
        {
            chunk.Add(item);
            if(chunk.Count == size)
            {
                yield return chunk;
                chunk = new List<T>(size);
            }
        }

        if(chunk.Count >  0)
        {
            yield return chunk;
        }
    }
}
