void	SortA(int[] A, int n)
{
	int	temp;
	for (int i=0; i<n-1; i++)
		for (int j=i+1; j<n; j++)
			if (A[i]>A[j])
			{	
				temp=A[i];
				A[i] = A[j];
				A[j] = temp;
			}
}

void	SortB(int[] A, int n)
{
	int	temp;
	for (int i=0; i<n-1; i++)
		for (int j=i+1; j<n; j++)
			if (A[i]<A[j])
			{	
				temp=A[i];
				A[i] = A[j];
				A[j] = temp;
			}
}


void	SortC(int[] A, int n)
{
	int	temp;
	for (int i=0; i<n-1; i++)
		for (int j=i+1; j<n; j++)
			if (_________________________)
			{	
				temp=A[i];
				A[i] = A[j];
				A[j] = temp;
			}
}


