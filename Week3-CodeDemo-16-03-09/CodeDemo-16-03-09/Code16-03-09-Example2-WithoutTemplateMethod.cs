int	FindA(int[] A, int n)
{
	int	result = 0;
	for (int i=1; i<n; i++)
		if (A[i] > A[result])
			result = i;
	return result;	
}


int	FindB(int[] A, int n)
{
	int	result = 0;
	for (int i=1; i<n; i++)
		if (A[i] <= A[result])
			result = i;
	return result;	
}

int	FindC(Fraction[] A, int n)
{
	int	result = -1;
	for (int i=0; i<n; i++)
		if ( (A[i] >= 0) &&
	         (result==-1))			
			result = i;
	return result;	
}


int	FindD(Film[] A, int n, float x)
{
	int	result = -1;
	for (int i=0; i<n; i++)
		if ( (A[i].Rating >= x) &&
	         (result==-1))			
			result = i;
	return result;	
}