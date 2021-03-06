using System.Threading.Tasks;
using UnityEngine;

namespace HouraiTeahouse.Loadables {

public class ResourcesAsset<T> : AbstractAsset<T> where T : Object {

  public string Path { get; }

  public ResourcesAsset(string path) {
    Path = path;
  }

  public override T LoadImpl() {
    return Resources.Load<T>(Path);
  }

  public override async Task<T> LoadAsyncImpl() {
    var request = await Resources.LoadAsync(Path).ToTask();
    return request.asset as T;
  }

  public override void UnloadImpl() {
    Resources.UnloadAsset(Asset);
  }

}

}
