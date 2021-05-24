function MinWindowSubstring(strArr) { 

	var strN = strArr[0];
	var strK = strArr[1];
  
	var candidates = [];
	var shortestSubStr = strN;
  
	var strIndex = 0;
  
	for(var strIndex = 0; strIndex < strN.length; strIndex++)
	{
	  var curChar = strN.charAt(strIndex);
  
	  //add new character to existing substrings
	  for(var i = 0; i < candidates.length; i++)
	  {
		candidates[i] += curChar;
	  }
  
	  //consider new character for a new substring
	  if(strK.includes(curChar))
	  {
		var newSubStr = curChar;
		candidates.push(newSubStr);
	  }
  
  
	  //evaluate candidates for completeness
	  for(var i = 0; i < candidates.length; i++)
	  {
		var tempCandidate = candidates[i].split("");
		var count = 0;
  
		for(var j = 0; j < strK.length; j++)
		{
		  var c = strK.charAt(j);
		  if(tempCandidate.includes(c))
		  {
			tempCandidate.splice(tempCandidate.indexOf(c), 1);
			count++;
		  }
		}
  
		if(count == strK.length)
		{
		  if(candidates[i].length < shortestSubStr.length) {shortestSubStr = candidates[i];}
		  candidates.splice(i, 1);
		  i--;
		}
	  }
	}
  
	return shortestSubStr;
  }