int s = 0;
string [] array = new string[5]{"hello", "2", "world", ":-)", "1"};
foreach(string i in array){
    if (i.Length <= 3) {
        s++;
    }
}
string [] answer = new string[s];
int j = 0;

foreach(string i in array){
    if (i.Length <= 3) {
        answer[j] = i;
        j++;
    }

}
for (int i = 0; i < answer.GetLength(0); i++){
    Console.Write($"{answer[i]} ");
}