using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node
{

    //設定第幾層第幾個點
    int height;
    int width;

    // 查看是否為可用格子
    bool is_valid;

    // 分辨事件，戰鬥等
    // s 商店
    // f 一般戰鬥
    // F 菁英
    // e 事件
    // t 寶箱
    // n none
    // b boss
    char type;
    //現在持有的點
    public Button node;
    
    //下面接了那些點
    public List<int> next;
    //上面接了那些點
    public List<int> parent;

    public bool Return_valid()
    {
        return is_valid;
    }
    public void Set_valid()
    {
        is_valid = true;
        node.image.color = Color.white;
    }
    public void Set_type(char t)
    {
        type = t;
    }
    public void Set_height(int h)
    {
        height = h;
    }
    public void Set_width(int w)
    {
        width = w;
    }
    public int Get_height()
    {
        return height;
    }
    public int Get_width()
    {
        return width;
    }
    public char Return_type()
    {
        return type;
    }
    public void Init()
    {
        height = 0;
        width = 0;
        is_valid = false;
        type = 'n';
        node.image.color = Color.black;
        next = new List<int>();
        parent = new List<int>();
        return;
    }
    //設定點的大小
    public void Set_node_size(Vector2 node_size)
    {
        node.GetComponent<RectTransform>().sizeDelta = node_size;
    }
}
