public class ActionGoHome : GAction {
    public override bool PrePerform() {

        return true;
    }

    public override bool PostPerform() {

        Destroy(this.gameObject);
        return true;
    }
}
