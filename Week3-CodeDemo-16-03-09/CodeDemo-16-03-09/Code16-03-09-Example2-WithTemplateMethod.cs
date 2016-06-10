// C#: object, var, string
// java: object, string
// C++: void*, string

class	Finder
{
		
	protected virtual int GetInitValue()
	{
		return 0;
	}

	protected virtual int GetStartValue()
	{
		return 1;
	}

	protected virtual bool IsSelected(object Ai, int result, object[] A, float x)
	{
		return false;
	}
	public int	Find(object[] A, int n, float x)
	{
		int	result = GetInitValue(); // 0 or -1
		for (int i=GetStartValue(); i<n; i++)
			if (IsSelected(A[i], result, A, x))
				result = i;
		return result;	
	}
}




class FinderA: Finder{
protected override bool IsSelected(object Ai, int result, object[] A, float x)
{
	int vi = (int)Ai;
	int vresult = (int)A[result];
	return vi > vresult;
}
}


class FinderB: Finder{
protected override bool IsSelected(object Ai, int result, object[] A, float x)
{
	int vi = (int)Ai;
	int vresult = (int)A[result];
	return vi <= vresult;
}
}

class FinderC: Finder{
protected override int GetInitValue()
{
	return -1;
}

protected override int GetStartValue()
{
	return 0;
}

protected override bool IsSelected(object Ai, int result, object[] A, float x)
{
	Fraction vi = (Fraction)Ai;
	return (vi>=0 && result == -1);
}
}

class FinderD: Finder{
protected override int GetInitValue()
{
	return -1;
}

protected override int GetStartValue()
{
	return 0;
}

protected override bool IsSelected(object Ai, int result, object[] A, float x)
{
	Film vi = (Film)Ai;
	return (vi.Rating>=x && result == -1);
}
}





