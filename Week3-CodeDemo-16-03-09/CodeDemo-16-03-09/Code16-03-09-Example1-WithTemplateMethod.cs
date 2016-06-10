class Sorter
{
protected virtual bool XXX(int v1, int v2)
{
	return false;
}
public void Sort(int[] A, int n)
{
	int	temp;
	for (int i=0; i<n-1; i++)
		for (int j=i+1; j<n; j++)
			if (XXX(A[i], A[j])
			{	
				temp=A[i];
				A[i] = A[j];
				A[j] = temp;
	
}
}

class SorterA: Sorter{
	protected override bool XXX(int v1, int v2)
	{
		return  v1 > v2;
	}
}

class SorterB: Sorter{
	protected override bool XXX(int v1, int v2)
	{
		return  v1 < v2;
	}
}

class SorterC: Sorter{
	protected override bool XXX(int v1, int v2)
	{
		return  Math.Abs(v1) > Math.Abs(v2);
	}
}


class SorterD: Sorter{
	protected override bool XXX(int v1, int v2)
	{
		if (IsEven(v1) && IsEven(v2) && v1 > v2) return true;
		if (IsOdd(v1) && IsOdd(v2) && v1 < v2) return true;
//		if (IsEven(v1) && IsOdd(v2)) return false;
		if (IsOdd(v1) && IsEven(v2)) return true;		
		return false;		
	}
}


class SorterE: Sorter{
	protected override bool XXX(int v1, int v2)
	{
		if (IsEven(v1) && IsEven(v2) && v1 > v2) return true;
		if (IsOdd(v1) && IsOdd(v2) && v1 < v2) return true;
		return false;		
	}
}