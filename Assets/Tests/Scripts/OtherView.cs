using UnityEngine;
using Zenject;

public class OtherView : MonoBehaviour
{
    [Inject] private OtherPresenter _otherPresenter;
}
