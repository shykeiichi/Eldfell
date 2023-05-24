using System.Net;
using System;

namespace Eldfell;

class Program
{
    [Get("/")]
    Response Index()
    {
        return new RenderTemplate("");
    }

    [Get("/User/:name")]
    Response User(string name)
    {
        return new Response(name);
    }

    public static void Main(string[] args)
    {
    
    }
}