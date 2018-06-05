//1
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityDemo.Models;
using UnityEngine;

public class chinswTest
{
    private List<Card> _cards;

    

    [Test]
    public void 덱에는_짝수가_5개_있어야함(){
        int evennumberCount=0;

        for(int i = 0; i < 10; i++)
        {
            if ((_cards[i].No % 2) == 0)
                evennumberCount++;
        }

        Assert.AreEqual(5,evennumberCount);
    }
}