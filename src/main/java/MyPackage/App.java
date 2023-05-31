package MyPackage;

public class App {


    public static void main(String[] args) {
        User user= new User("Juk","Juk201");
        User user1= new User("q","q");
        User user2= new User("tom","tomers");
        User coach= new User("1","1",true);
        User trainer= new User("Elizabeth Sawyer","saw",true);
        //User big= new User("Elizabeth II Very Big Name Sawyer Varai","saw",true);
        User coachTom= new User("Tomos Stuart","saturn",true);
        User coachAdam= new User("Aadam Weeks","week",true);

        PasswordDB.addUser(user,user1,user2,coach,trainer,coachTom,coachAdam);

        Controller windowApp = new Controller();
        windowApp.getLoginFrame().setVisible(true);
        ScheduledTraining training =new ScheduledTraining("Cardio",user.getUsername() ,
                "APRIL 10","APRIL 10 10:30 AM" ,"APRIL 10 11:30 AM");
        coach.addUserTraining(training);
        ScheduledTraining training1 =new ScheduledTraining("Dance",user1.getUsername() ,
                "APRIL 12","APRIL 12 11:30 AM" ,"APRIL 12 12:30 PM");
        coach.addUserTraining(training1);
        ScheduledTraining training2 =new ScheduledTraining("Cardio",user2.getUsername() ,
                "APRIL 13","APRIL 13 3:00 PM" ,"APRIL 13 4:00 PM");
        coach.addUserTraining(training2);
        ScheduledTraining training3 =new ScheduledTraining("Cardio",user.getUsername() ,
                "APRIL 12","APRIL 12 3:00 PM" ,"APRIL 12 4:00 PM");
        coach.addUserTraining(training3);
        ScheduledTraining training4 =new ScheduledTraining("Cardio",user.getUsername() ,
                "APRIL 14","APRIL 14 3:00 PM" ,"APRIL 14 4:00 PM");
        coach.addUserTraining(training4);
        ScheduledTraining training5 =new ScheduledTraining("Cardio",user2.getUsername() ,
                "APRIL 11","APRIL 11 3:00 PM" ,"APRIL 11 4:00 PM");
        coach.addUserTraining(training5);
        ScheduledTraining training6 =new ScheduledTraining("Cardio",user1.getUsername() ,
                "APRIL 12","APRIL 12 3:00 PM" ,"APRIL 12 4:00 PM");
        coach.addUserTraining(training6);
        ScheduledTraining training7 =new ScheduledTraining("Dance",user.getUsername() ,
                "APRIL 13","APRIL 13 3:00 PM" ,"APRIL 13 4:00 PM");
        coach.addUserTraining(training7);
    }

}
