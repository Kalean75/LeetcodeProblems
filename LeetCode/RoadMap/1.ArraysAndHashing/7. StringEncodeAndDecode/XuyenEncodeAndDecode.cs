public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count == 0) return null; 
        string encodedStr = "";
        for (int i = 0; i < strs.Count; i++) {
            encodedStr += "";
            int j = 0;
            if (strs[i].Length > 0) {
                for (j = 0; j < strs[i].Length-1; j++) {
                    encodedStr += (int)strs[i][j];
                    encodedStr += ",";
                }
                encodedStr += (int)strs[i][j];
            }
        }
        return encodedStr;
    }

    public List<string> Decode(string s) {
        if (s == null) return new List<string>();
        if (s.Length == 0) return new List<string>() {""};
        List<string> returned = new List<string>();
        string[] splited = s.Split("");
        for (int i = 1; i < splited.Length; i++) {
            string[] words = splited[i].Split(",");
            string decoded = "";
            foreach (string w in words) {
                if (w != "") {
                    int wAsNum = Int32.Parse(w);
                    decoded += (char)wAsNum;
                }
            }
            returned.Add(decoded);
        }
        return returned;
   }
}
