int[] array = new int[8]; 
PrintArray(array); 
Console.WriteLine(); 
var arr = FillArray(8); 
PrintArray(arr); 
 
int[] FillArray(int length) 
{ 
int[] result = new int[length]; 
for(int i =0; i < result.Length; i++) 
{ 
result[i] = new Random().Next(0, 50); 
} 
return result; 
} 
 
void PrintArray(int[] arr) 
{ 
for(int i = 0; i < arr.Length; i++) 
{ 
Console.Write($"{arr[i]}, "); 
} 
}