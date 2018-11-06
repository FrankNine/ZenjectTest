using UnityEngine;
using Zenject;

public class View : MonoBehaviour
{
    [Inject] private ViewModel _viewModel;
    private bool _isLogged;

    private void Update()
    {
        if (!_isLogged)
        {
            Debug.Log(_viewModel.a);
            _isLogged = true;
        }
    }
}
