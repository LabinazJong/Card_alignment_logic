# 카드의 정렬 로직

//내림차순 정렬 후 
```
void SortCardsinDescendingOrder()
{
   descendingArayy[0] = blue;
   descendingArayy[1] = red;
   descendingArayy[2] = green;
   descendingArayy[3] = yellow;

   for (int i = 0; i < 4; i++)
   {
     for (int j = 0; j < 4; j++)
     {
        if (descendingArayy[i] > num[j])
        {
           temp = descendingArayy[i];
           descendingArayy[i] = num[j];
           descendingArayy[j] = temp;
        }
     }
   }
}
```
// 카드 오브젝트 내용에 재분배
```
void SortingCards()
{
 for (int i = 0; i < num.Length; i++)
 {
    if (descendingArayy[i] == blue)
    {
        for (int j = 0; j < BlueList.Count; j++)
        {
            Pick_display[indexNum].card = BlueList[j];
             indexNum++;
         }
    }
    if (descendingArayy[i] == red)
    {
       for (int j = 0; j < RedList.Count; j++)
       {
           Pick_display[indexNum].card = RedList[j];
           indexNum++;
       }
     }
    if (descendingArayy[i] == green)
    {
        for (int j = 0; j < GreenList.Count; j++)
        {
           Pick_display[indexNum].card = GreenList[j];
           indexNum++;
         }
     }
    if (descendingArayy[i] == yellow)
     {
        for (int j = 0; j < YellowList.Count; j++)
        {
        Pick_display[indexNum].card = YellowList[j];
        indexNum++;
        }
     }
  }
}
```
