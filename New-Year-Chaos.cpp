void minimumBribes(vector<int> q)
{
    int total = 0;
    int test = 0;
    int n = q.size();
    
    for (size_t i = 0; i < q.size(); ++i)
    {
        int check = q[i] - (i + 1);

        if (check > 2)
        {
            total = -1;
            break;
        }

        for (size_t j = std::max(0, q[i] - 2); j < i; ++j)
        {
            if (q[j] > q[i])
            {
                total++;
            }
        }
    }

    if (total == -1)
    {
        cout << "Too chaotic" << '\n';
    }
    else
    {
        cout << total << '\n';
    }
}
