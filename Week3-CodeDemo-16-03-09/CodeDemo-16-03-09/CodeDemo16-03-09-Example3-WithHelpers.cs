class	Finder
{

	public	AbstractHelperGetInitValue HelperGetInitValue = null;
	public	AbstractHelperGetStartValue HelperGetStartValue = null;
	public	AbstractHelperIsSelected HelperIsSelected = null;
		
	public int	Find(object[] A, int n, float x)
	{
		int	result = HelperGetInitValue.GetValue(); // 0 or -1
		for (int i=HelperGetStartValue.GetValue(); i<n; i++)
			if (HelperIsSelected.GetResult(A[i], result, A, x))
				result = i;
		return result;	
	}
}





class FindBestValue
{
	// dùng object
	public SelectHelper pSelectHelper = new SelectHelper();
	public CompareHelper pCompareHelper = new CompareHelper();

	public int GetBestValue(int[] A, int n, int defValueIfNotFound)	
	{
		int result = -1;
		for (int i=0; i<n; i++)
			if (pSelectHelper.IsOK(A[i]))
				if (pCompareHelper.IsBetter(A[i], A, result))
					result = i;
				
		if (result!=-1)
			return A[result];
		//return pDefaultHelper.GetDefaultValue();
		return defValueIfNotFound;
	}
}


class SelectHelper
{
public virtual bool IsOK(int x)
{
	return true;
}
}


class PrimeSelectHelper: SelectHelper
{
public override bool IsOK(int x)
{
	return IsPrime(x);
}	
}


class NegativeSelectHelper: SelectHelper
{
public override bool IsOK(int x)
{
	return x<0;
}	
}


class EvenNumberSelectHelper: SelectHelper
{
public override bool IsOK(int x)
{
	return x%2 == 0;
}	
}

class CompareHelper
{
public virtual IsBetter	(int curValue, int[]A, int curBestIndex)
{
	if (curBestIndex==-1)
		return true;
	return false;
}
}

class MaxCompareHelper:compareHelper
{
public override IsBetter	(int curValue, int[]A, int curBestIndex)
{
	if (curBestIndex==-1)
		return true;
	if (curValue>A[curBestIndex])
		return true;
	return false;
}
	
}

class MinCompareHelper:compareHelper
{
public override IsBetter	(int curValue, int[]A, int curBestIndex)
{
	if (curBestIndex==-1)
		return true;
	if (curValue<A[curBestIndex])
		return true;
	return false;
}
	
}