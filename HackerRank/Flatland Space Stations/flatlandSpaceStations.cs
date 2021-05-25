/*
	Given a number of nodes (n), and an array of indixes (c) specifying which nodes are special, find the largest distance between any node and its closest special node.
	Nodes are connected sequentially by edges of equal distance, and do not loop.
*/
static int flatlandSpaceStations(int n, int[] c)
{
	int maxDist = 0;
	
	List<int> cList = c.ToList();
	cList.Sort();
	
	for(int i = 0; i < cList.Count-1; i++)
	{
		if(cList[i+1] - cList[i] > maxDist)
		{
			maxDist = cList[i+1] - cList[i];
		}
	}
	maxDist = (int)(maxDist/2);
	
	if(cList[0] > maxDist) { maxDist = cList[0]; }
	if(n-1-cList.Last() > maxDist) { maxDist = n-1-cList.Last(); }
	
	return maxDist;
}
    