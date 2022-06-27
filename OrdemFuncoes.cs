using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Ordem de execução de funções/métodos de evento
/// </summary>
public class OrdemFuncoes : MonoBehaviour
{
    // Chamado antes do start e após novo objeto instanciado
    private void Awake()
    {
        
    }

    //chamado se o objeto estiver ativo
    private void OnEnable()
    {
        
    }

    //chamado quando o script é anexo a um objeto ou quando é resetado
    private void Reset()
    {
        
    }

    //chamado antes do primeiro frame ao inicializar o projeto (somente se o objeto estiver ativo)
    private void Start()
    {
        
    }

    //chamado varias vezes por segundo, porem usado para calculos de fisica
    private void FixedUpdate()
    {
        
    }

    //chamado a cada frame pelo comonente Animator
    private void OnAnimatorMove()
    {
        
    }

    //chamado uma vez para cada layer do animator controller que tenha o IK ativo
    private void OnAnimatorIK(int layerIndex)
    {
        
    }

    //chamado uma vez quando colider com algum obj que seja trigger
    private void OnTriggerEnter(Collider other)
    {
        
    }

    //chamado uma vez quando colide com algum obj
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void Update()
    {
        
    }

    //chamado após todos os FixedUpdate da cena
    IEnumerator WaitForFixedUpdate()
    {
        yield return new WaitForFixedUpdate();
    }

    //detecta clique do mouse em algum objeto que tenha colisor
    private void OnMouseDown()
    {
        
    }

    //corrotina continua após todos os Updates serem chamados
    IEnumerator YieldNull()
    {
        yield return null;
    }

    //continua após um tempo de intervalo especificado
    IEnumerator YieldForSeconds()
    {
        yield return new WaitForSeconds(1f);
    }

    //continua após abrir um endereço web
    IEnumerator YieldWWW()
    {
        yield return new WWW("http://crieseusjogos.com.br");
    }

   
    void StartCorrotina()
    {
        //chamada a corrotina e aguarda até que seja concluída
        StartCoroutine(YieldNull());
    }

    //é chamado a cada frame após o Update
    private void LateUpdate()
    {
        
    }

    //chamado uma vez para cada camera se o objeto estiver visível
    private void OnWillRenderObject()
    {
        
    }

    //chamado antes da camera "enxergar" a cena
    private void OnPreCull()
    {
        
    }

    //chamado quando um objeto se torna visível para a camera
    private void OnBecameVisible()
    {
        
    }

    //chamado quando um objeto se torna invisível para a camera
    private void OnBecameInvisible()
    {
        
    }

    //chamado antes que a camera comece a renderizar a cena
    private void OnPreRender()
    {
        
    }

    //chamado depois que toda a renderização da cena é feita
    private void OnRenderObject()
    {
        
    }

    //chamado depois que uma camera terminar de renderizar a cena
    private void OnPostRender()
    {
        
    }

    //chamado após a renderização da cena com post processing
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        
    }

    //desenha gizmos apenas vistos na cena
    private void OnDrawGizmos()
    {
        
    }

    //chamado varias vezes por segundo para desenho da GUI
    private void OnGUI()
    {
        
    }

    //espera o termino do frame atual
    IEnumerator WaitForEndFram()
    {
        yield return new WaitForEndOfFrame();
    }

    //é chamado no final do frame em que o jogo está pausado
    private void OnApplicationPause(bool pause)
    {
        
    }

    //chamado antes que o jogo seja encerrado
    private void OnApplicationQuit()
    {
        
    }

    //chamado quando o objeto é desativado na cena
    private void OnDisable()
    {
        
    }

    //último quadro de existência de um objeto antes dele ser destruído ou a cena ser mudada
    private void OnDestroy()
    {
        
    }
}
