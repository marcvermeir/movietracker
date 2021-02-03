package com.mme.movietracker.api.controller;

import com.mme.movietracker.api.domain.Watchlist;
import com.mme.movietracker.api.repository.WatchlistRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;

@CrossOrigin(origins = "http://localhost:3000")
@RestController
@RequestMapping("/api/v1.0")
public class WatchlistController {

    @Autowired
    WatchlistRepository watchlistRepository;


    @GetMapping("/watchlists")
    public ResponseEntity<List<Watchlist>> getAllWatchlists(@RequestParam(required = false) String name) {
        try {
            List<Watchlist> watchlistList = new ArrayList<Watchlist>();

            //TODO: >>> quid delegating the following into a service implementation ??
            if (name == null)
                watchlistRepository.findAll().forEach(watchlistList::add);
            else
                watchlistRepository.findByNameContaining(name).forEach(watchlistList::add);

            if (watchlistList.isEmpty()) {
                return new ResponseEntity<>(HttpStatus.NO_CONTENT);
            }

            return new ResponseEntity<>(watchlistList, HttpStatus.OK);

        //TODO: >>> refactor this into some generic exception handling ..
        } catch (Exception e) {
            return new ResponseEntity<>(null, HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    //TODO: >>> add/implement the other REST API operations/methods .. https://bezkoder.com/spring-boot-jpa-crud-rest-api/
}
