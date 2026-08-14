string result = "";
for (int i = 0; i < 1000; i++)
    result += i.ToString();

// Good: Uses a mutable buffer
var sb = new StringBuilder();
for (int i = 0; i < 1000; i++)
    sb.Append(i);
string result = sb.ToString();