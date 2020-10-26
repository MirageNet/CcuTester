using System.Collections;
using UnityEngine;

namespace Mirror.HeadlessBenchmark
{
    public class AdjustableLoad : NetworkBehaviour
    {

        public void Start()
        {
            NetIdentity.OnStartAuthority.AddListener(() => StartCoroutine(Click()));
        }

        private IEnumerator Click()
        {
            while (true)
            {
                ClickSomething();
                yield return new WaitForSeconds(Random.Range(0f, 5f));
            }
        }

        [ServerRpc]
        public void ClickSomething()
        {
        }
    }
}
