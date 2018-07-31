using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Animator _animator;
	void Awake () {
        _animator = GetComponent<Animator>();
	}
	
    public void OnClick1()
    {
        _animator.SetTrigger("Take1");
    }
    public void OnClick2()
    {
        _animator.SetTrigger("Take2");
    }
    public void OnClick3()
    {
        _animator.SetTrigger("Take3");
    }
    public void OnClick4()
    {
        _animator.SetTrigger("Take4");
    }
    public void OnClick5()
    {
        _animator.SetTrigger("Take5");
    }
    public void OnClick6()
    {
        _animator.SetTrigger("Take6");
    }
    public void OnClick7()
    {
        _animator.SetTrigger("Take2");
    }
    public void OnClick8()
    {
        _animator.SetTrigger("Take3");
    }
    public void OnClick9()
    {
        _animator.SetTrigger("Take4");
    }
    public void OnClick10()
    {
        _animator.SetTrigger("Take5");
    }
}
