//*****************************************************************************
//** 650. 2 Keys Keyboard  leetcode                                          **
//** Two solutions provided here.  The slower one is commented out, the      **
//** faster one is below, not commented out.                   -Dan          **
//*****************************************************************************


/*
int minSteps(int n) {
    int step = 0;
    int A = 1;
    int copyA = 1;
    while(A < n)
    {
        int nextA = A + copyA;
        A += copyA;
        if((n - nextA) % nextA)
        {
            step++;
        }
        else
        {
            copyA = nextA;
            step = step + 2;
        }
    }
    return step;
}
*/
int minSteps(int n)
{
    int step = 0;
    int d = 2; // Start from the smallest factor (2)
    
    while (n > 1)
    {
        while (n % d == 0)
        {
            step += d;
            n /= d;
        }
        d++;
    }
    
    return step;
}