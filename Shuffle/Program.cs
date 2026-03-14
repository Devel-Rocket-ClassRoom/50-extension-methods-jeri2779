using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.
public static class Shuffle
{
    public static List<T> ShuffleList<T>(List<T> inputList)
    {
        // Fisher-Yates 알고리즘을 사용하여 리스트를 섞습니다.
        Random random = new Random();
        int n = inputList.Count;
        
        for (int i = n - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1); // 0부터 i까지의 랜덤 인덱스 선택
            // 요소를 교환합니다.
            T temp = inputList[i];
            inputList[i] = inputList[j];
            inputList[j] = temp;
        }
        
        return inputList; // 섞인 리스트를 반환합니다.
    }
}
