static int alternate(string s)
	{
        List<char[]> pairs = new List<char[]>();
        List<char> chars = s.ToCharArray().ToHashSet().ToList(); //Remove duplicate letters by converting to a hash set
        
		//get all the possible pairs
        for(int i = 0; i < chars.Count-1; i++)
        {
            for(int j = i+1; j < chars.Count; j++)
            {
                pairs.Add(new char[2]);
                pairs.Last()[0] = chars[i];
                pairs.Last()[1] = chars[j];
                Console.WriteLine(chars[i] + ", " + chars[j]);
            }
        }
        
        //For each pair, test if its valid
        bool valid = true;
        int longest = 0;
        foreach(char[] pair in pairs)
        {
			//remove excess letters
            chars = s.ToCharArray().ToList();
            for(int i = 0; i < chars.Count; i++)
            {
                if(!pair.Contains(chars[i]))
                {
                    chars.Remove(chars[i]);
                    i--;
                }
            }
            
			//check if its valid
            valid = true;
            int charIndex = pair.ToList().IndexOf(chars[0]);
            for(int i = 0; i < chars.Count; i++)
            {
                if(chars[i] != pair[charIndex])
                {
                    valid = false;
                    break;
                }
                charIndex = Math.Abs(charIndex-1);
            }
            
			//if its valid, chech if it is the longest
            if(valid == true)
            {
                if(String.Join("", chars).Length > longest)
                {
                    longest = String.Join("", chars).Length;
                }
                Console.WriteLine(String.Join("", chars));
            }
        }
        
        return longest;
    }