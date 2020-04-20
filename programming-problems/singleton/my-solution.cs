// CHOOI GUAN LIM solution
public class Solution
{
	static public int Run(int[] student_list)
	{
		int single_student_number = 0;
		foreach (var student in student_list)
		{
			single_student_number ^= student;
		}
		return single_student_number;
	}
}