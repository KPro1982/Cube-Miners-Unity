public class ActionGoToWaitingRoom : GAction {
    public override bool PrePerform() {

        return true;
    }

    public override bool PostPerform() {

        // Inject waiting state to world states
        GWorld.Instance.GetWorld().ModifyState("Waiting", 1);
        // EntityPatient adds himself to the queue
        GWorld.Instance.AddPatient(this.gameObject);
        // Inject a state into the agents agentStates
        agentStates.ModifyState("atHospital", 1);

        return true;
    }
}
