using System;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.
public static class Chunk
{
    public static List<List<T>> ChunkList<T>(List<T> inputList, int chunkSize)
    {
        // 입력 리스트를 chunkSize 크기로 나누어 새로운 리스트로 반환합니다.
        return inputList
            .Select((item, index) => new { item, index }) // 요소와 인덱스를 함께 선택합니다.
            .GroupBy(x => x.index / chunkSize) // 인덱스를 chunkSize로 나눈 몫을 기준으로 그룹화합니다.
            .Select(group => group.Select(x => x.item).ToList()) // 각 그룹에서 요소만 추출하여 리스트로 만듭니다.
            .ToList(); // 최종적으로 리스트의 리스트로 반환합니다.
    }
}
