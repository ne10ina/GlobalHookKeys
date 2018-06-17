"# GlobalHookKeys".

Made in Visual Studio 2017 C#.
Needs Windows.System

How to use:

Make new class globalHookKeys - globalHookKeys key = new globalHookKeys();
Then add a key to hook - key.HookedKeys.Add(Key.*key*);
Make event - key.KeyUp += new KeyEventHandler(key_KeyUp);
             key.KKeyDown += new KeyEventHandler(key_KeyDown);
             
And finally create a function

void key_KeyUp(object sender, KeyEventArgs e)
{
    //logic here
}

void key_KeyDown(object sender, KeyEventArgs e)
{
    //logic here
}
