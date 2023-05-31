package MyPackage;

import java.util.*;

public class User {
    private String username;
    private String password;
    private List<ScheduledTraining> scheduledTrainings;
    private List<ScheduledTraining> userTrainings;
    private HashMap<String,StringBuffer> coachTrainings;
    private boolean coach;

    public User(String username, String password) {
        this.username = username;
        this.password = password;
        scheduledTrainings =new ArrayList<>();
        userTrainings=new ArrayList<>();
        coachTrainings = new HashMap<String,StringBuffer>();
        coach =false;
    }

    public User(String username, String password, boolean Coach) {
        this.username = username;
        this.password = password;
        scheduledTrainings =new ArrayList<>();
        userTrainings=new ArrayList<>();
        coachTrainings = new HashMap<String,StringBuffer>();
        this.coach = Coach;
    }

    public String getUsername() {
        return username;
    }
    public boolean checkPassword(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        User user = (User) o;
        return password.equals(user.password) ;
    }

    public List<ScheduledTraining> getUserTrainings() {
        return userTrainings;
    }

    public void setUserTrainings(List<ScheduledTraining> scheduledTrainings) {
        this.scheduledTrainings = scheduledTrainings;
    }

    public List<ScheduledTraining> getScheduledTrainings() {
        return scheduledTrainings;
    }

    public void setScheduledTrainings(List<ScheduledTraining> scheduledTrainings) {
        this.scheduledTrainings = scheduledTrainings;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public boolean isCoach() {
        return coach;
    }

    public void setCoach(boolean coach) {
        this.coach = coach;
    }

    public void addTraining(ScheduledTraining training){
        scheduledTrainings.add(training);
    }

    public void addUserTraining(ScheduledTraining training){
        userTrainings.add(training);
    }

    public HashMap<String, StringBuffer> getCoachTrainings() {
        return coachTrainings;
    }

    public void setCoachTrainings(HashMap<String, StringBuffer> coachTrainings) {
        this.coachTrainings = coachTrainings;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        User user = (User) o;
        return coach == user.coach && username.equals(user.username) && password.equals(user.password) && scheduledTrainings.equals(user.scheduledTrainings) && userTrainings.equals(user.userTrainings) && coachTrainings.equals(user.coachTrainings);
    }

    @Override
    public int hashCode() {
        return Objects.hash(username, password, scheduledTrainings, userTrainings, coachTrainings, coach);
    }

    @Override
    public String toString() {
        return "User{" +
                "username='" + username + '\'' +
                ", password='" + password + '\'' +
                ", scheduledTrainings=" + scheduledTrainings +
                ", userTrainings=" + userTrainings +
                ", coachTrainings=" + coachTrainings +
                ", coach=" + coach +
                '}';
    }
}
